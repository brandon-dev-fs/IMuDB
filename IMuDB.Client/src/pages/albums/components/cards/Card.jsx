import classes from './Card.module.css';
import { CardLink } from './components/CardLink';
import { CardBody } from './components/CardBody';
import { CardHeader } from './components/CardHeader';
import { CardImage } from './components/CardImage';

export default function Card({ album }) {
	return (
		<div className={classes.card}>
			<CardImage
				src={album.imageUrl}
				alt={`Album cover for ${album.name}`}
			/>
			<CardBody>
				<CardHeader text={album.name} />
				<CardLink link={`/albums/${album.id}`} />
			</CardBody>
		</div>
	);
}
