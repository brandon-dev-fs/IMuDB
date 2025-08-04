import React from 'react';
// Stateless component used only for rendering list of artist
// Artist are passed in and the list is rendered and styled based on that list
export default function SongList({ songs }) {
	return (
		<ul className="list">
			{songs.map((s) => (
				<li key={s.id} className="list-item">
					{s.track}. <a className="btn-text" href={`/songs/${s.id}`}>{s.name}</a>
				</li>
			))}
		</ul>
	);
}
