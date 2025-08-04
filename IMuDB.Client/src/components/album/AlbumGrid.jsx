import React from 'react';
import AlbumCard from './AlbumCard';

export default function AlbumGrid({ albums }) {
    return (
        <div className="flex flex-wrap center">
            {albums.map((a) => (
                <AlbumCard key={a.id} album={a}>
                </AlbumCard>
            ))}
        </div>
    );
}
