import React, { useState } from 'react';
import classes from './AlbumSearch.module.css';

export default function AlbumSearch({ onSearch }) {
	const [searchText, setSearchText] = useState('');
	const handleUpdateSearch = (e) => {
		const value = e.target.value.toLowerCase();
		if (value.length > 0) {
			// Set search for the value of the input
			// Pass to the onSearch prop function
			setSearchText(value);
			onSearch(value);
		} else {
			setSearchText('');
			onSearch('');
		}
	};

	return (
		<div className={`${classes.album_search_container}`}>
			<input
				onChange={handleUpdateSearch}
				className={`${classes.album_search}`}
				value={searchText}
				placeholder="search"
			/>
		</div>
	);
}
