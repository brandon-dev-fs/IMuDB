import React from 'react';

export default function AlbumList({ albums }) {
	return (
		<ul className="list">
			{albums.map((a) => (
				<li key={a.id} className="list-item">
					({a.year}) <a className="btn-text" href={`/albums/${a.id}`}>{a.name}</a>
				</li>
			))}
		</ul>
	);
}
