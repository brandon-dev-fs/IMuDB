import React, { useEffect, useState } from 'react';
import { Link, useNavigate, useParams } from 'react-router-dom';
import { getAlbumById, getSongById } from '../../../services/httprequest';
import Loading from '../../loading/Loading';
import Modal from '../../global/modal/Modal';
import List from '../../list/List';
import SongDetails from '../../song/details/SongDetails';
import SongElement from '../../song/elements/SongElement';

function AlbumDetails() {
	const params = useParams();
	const navigate = useNavigate();
	const albumId = params.id;
	const [loading, setLoading] = useState(true);
	const [album, setAlbum] = useState({});
	const [selectedSong, setSelectedSong] = useState(null);
	const [showModal, setShowModal] = useState(false);

	useEffect(() => {
		getAlbumById(albumId)
			.then((a) => {
				console.log(a);
				setLoading(false);
				setAlbum(a);
			})
			.catch((err) => {
				console.error(err);
				navigate('404');
			});
	}, [albumId, navigate]);

	const songClicked = (id) => {
		getSongById(albumId, id)
			.then((s) => {
				console.log(s);
				setSelectedSong(s);
				setShowModal(true);
			})
			.catch((err) => console.error(err));
	};

	const songElement = (s) => (
		<SongElement
			clickAction={songClicked}
			song={s}
		/>
	);

	return loading ? (
		<Loading />
	) : (
		<section className="grid p-y-s p-x-l">
			<div className="flex space-around">
				<div className="p-y-s">
					<img
						className="image-large p-y-s"
						src={`${album.imageUrl}`}
					/>
				</div>
				<div className="p-y-s">
					<div>
						<h2>{album.name}</h2>
					</div>

					<div>
						<p>
							Musician:{' '}
							<span>
								<Link
									className="btn-text"
									to={`/acts/${album.act.id}`}
								>
									{album.act.name}
								</Link>
							</span>
						</p>
					</div>
					<div>
						<p>Year: {album.year}</p>
					</div>
				</div>
			</div>

			<div className="p-y-s">
				<h2>Tracks</h2>
				<List
					data={album.songs}
					renderElement={songElement}
				/>
			</div>
			{showModal && (
				<Modal setShowModal={setShowModal}>
					<SongDetails song={selectedSong} />
				</Modal>
			)}
		</section>
	);
}

export default AlbumDetails;
