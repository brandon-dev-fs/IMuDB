import classes from './HomeHero.module.css';

export default function HomeHero() {
	return (
		<div
			className={`grid grid-col-2 gap-s items-center align-center ${classes.hero_section}`}
		>
			{/* <div className={`${classes.hero_content}`}>
				<h1 className={`${classes.hero_content_heading}`}>
					Welcome to the Internet Music DataBase
				</h1>
			</div>
			<div className={`${classes.hero_content}`}>
				<p className={`${classes.hero_content_subheading}`}>
					Your music
					<br />
					Your way
				</p>
			</div> */}
			<div className={`${classes.hero_content}`}>
				<h1 className={`${classes.hero_content_heading}`}>
					Your music
					<br />
					Your way
				</h1>
			</div>
			<div className={`${classes.hero_content}`}>
				<h2 className={`${classes.hero_content_subheading}`}>
					Welcome to the Internet Music DataBase
				</h2>
			</div>
			<div className="grid-item-row">
				<a
					className={`btn btn-primary ${classes.hero_link}`}
					href="#"
				>
					Sign In
				</a>
				<a
					className={`btn btn-outline ${classes.hero_link}`}
					href="/albums"
				>
					Find an Album
				</a>
			</div>
		</div>
	);
}
