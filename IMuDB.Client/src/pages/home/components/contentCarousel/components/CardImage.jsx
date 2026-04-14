import classes from './CardImage.module.css';

export function CardImage({ src, alt }) {
	return (
			<img
				className={`image image-large ${classes.content_img}`}
				alt={alt}
				src={src}
			/>
	);
}
