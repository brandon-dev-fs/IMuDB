import React, { useState } from 'react';
import classes from './ActsSearch.module.css';

export default function ActsSearch({ onSearch }) {
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
		<div className={`${classes.act_search_container}`}>
			<input
				onChange={handleUpdateSearch}
				className={`${classes.act_search}`}
				value={searchText}
				placeholder="search"
			/>
		</div>
	);
}
