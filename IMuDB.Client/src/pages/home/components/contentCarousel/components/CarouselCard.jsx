import classes from './CarouselCard.module.css';

export function CarouselCard({ children }) {
	return (
		<div className={`${classes.card_content} flex align-center gap-m`}>
			{children}
		</div>
	);
}
