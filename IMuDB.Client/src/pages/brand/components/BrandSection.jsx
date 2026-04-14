import classes from './BrandSection.module.css';

export function BrandSection({ header, children }) {
	return (
		<section className={`${classes.brand_section}`}>
			<h2>{header}</h2>
			<hr />
			{children}
		</section>
	);
}
