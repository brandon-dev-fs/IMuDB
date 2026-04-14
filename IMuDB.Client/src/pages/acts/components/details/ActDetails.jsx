import { useEffect, useState } from 'react';
import { getActById } from '../../../../services/httprequest';
import Loading from '../../../../components/loading/Loading';
import MusiciansList from './components/list/MusiciansList';
import AlbumList from './components/list/AlbumsList';
import classes from './ActDetails.module.css';

function ActDetails({ actId }) {
	const [loading, setLoading] = useState(true);
	const [act, setAct] = useState({});

	useEffect(() => {
		getActById(actId)
			.then((a) => {
				console.log(a);
				setAct(a);
			})
			.catch((err) => {
				console.error(err);
			})
			.finally(() => setLoading(false));
	}, [actId]);

	return loading ? (
		<Loading />
	) : (
		act && (
			<section className={`${classes.act_details}`}>
				<h2>
					{act.name} ({act.type === 0 ? 'Musician' : 'Band'})
				</h2>
				<div className="flex gap-l">
					<img
						className="image-large"
						src={act.imageUrl}
					/>
					{act.musicians && (
						<MusiciansList musicians={act.musicians} />
					)}
				</div>
				{act.albums.length > 0 && (
					<AlbumList
						albums={act.albums.sort((a, b) => a.year - b.year)}
					/>
				)}
			</section>
		)
	);
}

export default ActDetails;
