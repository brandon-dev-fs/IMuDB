import classes from './TypographyBrand.module.css';

export function TypographyBrand() {
	return (
		<ul className={classes.list}>
			<li>
				<h1>Header 1</h1>
			</li>
			<li>
				<h2>Header 2</h2>
			</li>
			<li>
				<h3>Header 3</h3>
			</li>
			<li>
				<h4>Header 4</h4>
			</li>
			<li>
				<h5>Header 5</h5>
			</li>
			<li>
				<p>Normal Text</p>
			</li>
			<li>
				<small>Small Text</small>
			</li>
		</ul>
	);
}
