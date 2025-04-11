import React from 'react';
import { useNavigate } from 'react-router-dom';
import styled from 'styled-components';

// Stateless component used only for rendering list of artist
// Artist are passed in and the list is rendered and styled based on that list

export default function ArtistList({ artists }) {
	const navigate = useNavigate();
	const navigateOnClick = (id) => {
		navigate(`/artists/${id}`);
	};

	return (
		<ul className="artist-list">
			{artists.map((a) => (
				<li key={a.id} className="artist-list-item clickable" onClick={() => navigateOnClick(a.id)}>
						{a.name}
					</li>
			))}
		</ul>
	);
}
