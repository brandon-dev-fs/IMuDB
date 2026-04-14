import AlbumElement from '../elements/AlbumElement';

export default function AlbumList({ albums }) {
	return (
		<div>
			<h3>Albums</h3>
			<ul className="flex flex-wrap gap-s">
				{albums.map((a, i) => (
					<li key={i}>
						<AlbumElement album={a} />
					</li>
				))}
			</ul>
		</div>
	);
}
