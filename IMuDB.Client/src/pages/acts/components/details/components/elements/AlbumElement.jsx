import React from 'react';
import classes from './AlbumElement.module.css';

function AlbumElement({ album }) {
	return (
		<div
			className={`flex align-center space-between gap-xs ${classes.album_card}`}
		>
			<img
				src={album.imageUrl}
				alt={album.name}
				className="image-smaller"
			/>
			<a
				className="btn-text"
				href={`/albums/${album.id}`}
			>
				{album.name}
			</a>
			<span>({album.year})</span>
		</div>
	);
}

export default AlbumElement;
