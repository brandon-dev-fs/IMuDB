import classes from './ActsList.module.css';

export default function ActsList({ acts, onAddAct, onActSelected }) {
	return (
		<ul className={classes.acts_list}>
			{acts.map((a) => (
				<li
					key={a.id}
					className={classes.acts_list_item}
					onClick={() => onActSelected(a.id)}
				>
					{a.name}
				</li>
			))}
			<button
				className="btn btn-text"
				type="button"
				onClick={onAddAct}
			>
				+
			</button>
		</ul>
	);
}
