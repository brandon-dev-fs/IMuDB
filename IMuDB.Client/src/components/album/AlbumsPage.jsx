import React, { useEffect, useState } from 'react';
import { getAlbums } from '../../services/httprequest';
import AlbumGrid from './AlbumGrid';
import Loading from '../loading/loading';
import SearchBar from '../searchbar/SearchBar'

export default function AlbumsPage() {
	const [loading, setLoading] = useState(true);
	const [albums, setAlbums] = useState([]);
	const [filteredAlbums, setFilteredAlbums] = useState([]);

	useEffect(() => {
		getAlbums()
		    .then(a => {
		        console.log(a);
		        setLoading(false);
		        setAlbums(a);
		        setFilteredAlbums(a);
		    }).catch(e => {
		        console.log(e);
		        setLoading(false);
		    });

		setLoading(false);
		setFilteredAlbums(albums);
	}, []);

	if (loading) {
		return (
			<article>
				{loading && <Loading />}
			</article>
		);
	} else {
		return (
			<article className="page">
				{filteredAlbums && (
					<>
						<section className="page-heading p-s">
							<h1>Albums</h1>
							{/*<SearchBar placeholder="Search Albums" list={albums} setSearchedList={setFilteredAlbums} />*/}
							{/*<button className="button add-button">*/}
							{/*	Add New Album*/}
							{/*</button>*/}
						</section>
						<section className="page-content flex">
							<div className="page-content_section">
								<h2>Filters</h2>
								<form name="albumsFilter">
									<label>Artist</label>
									<label>Year</label>
								</form>
							</div>
							<div className="page-content_section">
								<AlbumGrid albums={filteredAlbums} />
							</div>
						</section>
					</>
				)}
			</article>
		);
	}
}