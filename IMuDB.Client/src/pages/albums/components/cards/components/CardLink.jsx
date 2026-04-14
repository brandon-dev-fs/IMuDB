import classes from './CardLink.module.css';

export function CardLink({ link }) {
	return (
		<div className={classes.card_link_container}>
			<a
				href={link}
				className={classes.card_link}
			>
				Album Details &rarr;
			</a>
		</div>
	);
}
