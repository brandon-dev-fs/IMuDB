import React, { useEffect, useState } from 'react';
import { useParams, useNavigate } from 'react-router';
import { getAlbumById } from '../../services/httprequest';
import SongList from '../song/SongList';
import Loading from '../loading/loading';

export default function AlbumDetailsPage() {
    const params = useParams();
    const navigate = useNavigate();
    const albumId = params.id;
    const [loading, setLoading] = useState(true);
    const [album, setAlbum] = useState({});
    //const [selectedSong, setSelectedSong] = useState(null);
    
    useEffect(() => {
        getAlbumById(albumId)
            .then(a => {
                console.log(a);
                setLoading(false);
                setAlbum(a);
            }).catch(e => {
                console.log(e);
                navigate('404');
            });
    }, []);

    if (loading) {
        return (
            <article>
                {loading && <Loading />}
            </article>
        );
    } else {
        return (
            <article className="page">
                <div className="page-heading">
                    <h1>{album.name}</h1>
                </div>
                <section className="page-content flex space-evenly">
                    <div className=" page-content_section col-top">
                    <h2>Artist</h2>
                    <a className="btn-text" href={`/artists/${album.artist.id}`}>{album.artist.name}</a>
                        <h2>Year</h2>
                        <p>{album.year}</p>
                    </div>
                    <div className="page-content_section col-top">
                        <h2>Song List</h2>
                        <SongList songs={album.songs} />
                    </div>
                </section>
            </article>
        )
    }
}