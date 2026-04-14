import classes from './CardHeader.module.css';

export function CardHeader({ text = '' }) {
	return (
		<div className={classes.card_header}>
			<h3 className={classes.card_title}>{text}</h3>
		</div>
	);
}
