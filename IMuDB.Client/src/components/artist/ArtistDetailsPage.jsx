import React, { useEffect, useState } from 'react';
import { useParams } from 'react-router';
import { getArtistById } from '../../services/httprequest';
import Loading from '../loading/loading';
import AlbumList from '../album/albumlist';
export default function ArtistDetailsPage() {
    const params = useParams();
    const artistId = params.id;
    const [loading, setLoading] = useState(true);
    const [artist, setArtist] = useState({});

    useEffect(() => {
        getArtistById(artistId)
            .then(a => {
                console.log(a);
                setLoading(false);
                setArtist(a);
            })
            .catch(e => {
                console.log(e)
                setLoading(false);
            });
    }, []);

    if (loading) {
        return (<div>
            {loading && <Loading />}
        </div>
        );
    } else {
        return (
            <article className="page">
                <div className="page-heading">
                    <h2>{artist.name}</h2><span>({artist.type === 0 ? "Solo" : "Band"})</span>
                </div>
                <section className="page-content flex space-evenly">
                    <div className="page-content_section col-top">
                            <h2>Musicians</h2>
                            {artist.musicians && (
                                <ul>
                                    {artist.musicians.map((m, i) => (
                                        <li key={i}>{m}</li>
                                    ))}
                                </ul>
                            )}
                    </div>
                    <div className="page-content_section col-top">
                        <h2>Albums</h2>
                        {artist.albums.length > 0 && (
                            <AlbumList albums={artist.albums.sort((a, b) => a.year - b.year)} />
                        )}
                    </div>
                </section>
            </article>)
    }
}