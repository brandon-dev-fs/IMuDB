import classes from './CardImage.module.css';

export function CardImage({ src, alt }) {
	return (
		<img
			className={`image ${classes.card_image}`}
			src={src}
			alt={alt}
		></img>
	);
}
