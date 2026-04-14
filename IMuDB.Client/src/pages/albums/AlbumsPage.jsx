import React, { useEffect, useState } from 'react';
import Loading from '../../components/loading/Loading';
import Grid from './components/grids/Grid';
import { getAlbums } from '../../services/httprequest';
import classes from './AlbumsPage.module.css';
import AlbumSidebar from './components/sidebar/AlbumSidebar';
import AlbumSearch from './components/sidebar/components/search/AlbumSearch';
import AlbumFilter from './components/sidebar/components/filters/Filters';
import AlbumsSort from './components/sidebar/components/sort/AlbumsSort';

export default function AlbumsPage() {
	const [loading, setLoading] = useState(true);
	const [filteredAlbums, setFilteredAlbums] = useState([]);
	const [albums, setAlbums] = useState([]);

	useEffect(() => {
		getAlbums()
			.then((a) => {
				const sortedAlbums = a.sort((a, b) =>
					a.name.localeCompare(b.name),
				);
				console.log(a);
				setAlbums(sortedAlbums);
				setFilteredAlbums(sortedAlbums);
			})
			.catch((err) => {
				console.error(err);
			})
			.finally(setLoading(false));
	}, []);

	const handleSearch = (searchString) => {
		// lazy search for now just direct string compare
		if (searchString) {
			setFilteredAlbums(
				albums.filter((a) =>
					a.name.toLowerCase().includes(searchString),
				),
			);
		} else {
			setFilteredAlbums(albums);
		}
	};

	const handleSort = (sortType) => {
		switch (sortType) {
			case 'A-Z':
				setFilteredAlbums(
					[...albums].sort((a, b) => a.name.localeCompare(b.name)),
				);
				break;
			case 'Z-A':
				setFilteredAlbums(
					[...albums].sort((a, b) => b.name.localeCompare(a.name)),
				);
				break;
			case 'Year Acs':
				setFilteredAlbums([...albums].sort((a, b) => a.year - b.year));
				break;
			case 'Year Desc':
				setFilteredAlbums([...albums].sort((a, b) => b.year - a.year));
				break;
			default:
				setFilteredAlbums(albums);
				break;
		}
	};

	return loading ? (
		<Loading />
	) : (
		filteredAlbums && (
			<div className={`flex`}>
				<AlbumSidebar>
					<AlbumSearch onSearch={handleSearch} />
					<AlbumsSort
						onSetSort={handleSort}
						sortOptions={['A-Z', 'Z-A', 'Year Acs', 'Year Desc']}
					/>
					{/* <AlbumFilter onSetFilter={() => {}} /> */}
				</AlbumSidebar>
				<section className={`${classes.album_grid_container}`}>
					<Grid elements={filteredAlbums} />
				</section>
			</div>
		)
	);
}
