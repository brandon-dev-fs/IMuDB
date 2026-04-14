import MusicianElement from '../elements/MusicianElement';

export default function MusiciansList({ musicians }) {
	return (
		<div>
			<h3>Musicians</h3>
			{musicians.map((m, i) => (
				<MusicianElement
					key={i}
					musician={m}
				/>
			))}
		</div>
	);
}
