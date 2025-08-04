import React from 'react';
import { useNavigate } from 'react-router';

export default function AlbumCard({ album }) {
    //For on click navigation
    const navigate = useNavigate();
    const navigateOnClick = (id) => {
        navigate(`/albums/${id}`);
    };

    return (
        <button className="card" onClick={() => navigateOnClick(album.id)}>
            <div className="card-header">
                <h2>
                    {album.name}
                </h2>
            </div>
            <div className="card-body">
                <p>Artist: {album.artist.name}</p>
                <p>Year: {album.year}</p>
            </div>
        </button>
    );
}
