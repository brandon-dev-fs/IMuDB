import classes from './ButtonBrand.module.css';

export function ButtonBrand() {
	return (
		<>
			<h3>Color Buttons</h3>
			<ul className={`${classes.list}`}>
				<li>
					<button
						className="btn btn-primary"
						id="primary-button"
					>
						Primary
					</button>
				</li>
				<li>
					<button
						id="secondary-button"
						className="btn btn-secondary"
					>
						Secondary
					</button>
				</li>
				<li>
					<button
						id="outline-button"
						className="btn btn-outline"
					>
						Outlined
					</button>
				</li>
			</ul>
			<h3>Text Buttons/Anchor Tags</h3>
			<ul className={`${classes.list}`}>
				<li>
					<button
						id="text-button"
						className="btn btn-text"
					>
						Text
					</button>
				</li>
				<li>
					<a href="#">Anchor Tag</a>
				</li>
			</ul>
		</>
	);
}
