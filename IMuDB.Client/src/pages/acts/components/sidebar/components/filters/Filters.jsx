import React, { useState } from 'react';
import classes from './Filters.module.css';

export default function ActFilters({filterType = -1, onSetFilter}) {
	const [typeFilter, setTypeFilter] = useState(filterType);

	const handleTypeFilter = (e) => {
		onSetFilter(Number(e.target.value));
		setTypeFilter(Number(e.target.value));
	}

	return (
		<div className={`${classes.input_container}`}>
			<label
				className={`${classes.input_label}`}
				htmlFor="filter-select"
			>
				Type
			</label>
			<select
				id="filter-select"
				className={`${classes.select}`}
				onChange={handleTypeFilter}
				value={typeFilter}
			>
				<option value={-1}>All</option>
				<option value={0}>Solo Acts</option>
				<option value={1}>Bands</option>
			</select>
		</div>
	);
}
