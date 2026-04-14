import { useState } from 'react';
import classes from './AlbumsSort.module.css';

export default function ActsSort({ onSetSort, sortOptions = [] }) {
	const [sortSelection, setSortSelection] = useState(sortOptions[0]);

	const handleSortSelection = (e) => {
		onSetSort(e.target.value);
		setSortSelection(e.target.value);
	};

	return (
		<div className={`${classes.input_container}`}>
			<label
				className={`${classes.input_label}`}
				htmlFor="sort-select"
			>
				Sort
			</label>
			<select
				id="sort-select"
				className={`${classes.select}`}
				onChange={handleSortSelection}
				value={sortSelection}
			>
				{sortOptions?.map((o, i) => (
					<option
						className={`${classes.option}`}
						key={i}
						value={o}
					>
						{o}
					</option>
				))}
			</select>
		</div>
	);
}
