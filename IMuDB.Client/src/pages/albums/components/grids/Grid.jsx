import Card from '../cards/Card';
import classes from './Grid.module.css';

export default function Grid({ elements }) {
	return (
		<div className={`flex flex-wrap space-between gap-s`}>
			{elements.map((a) => (
				<Card
					key={a.id}
					album={a}
				/>
			))}
		</div>
	);
}
