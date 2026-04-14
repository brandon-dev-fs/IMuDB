import classes from './ColorBrand.module.css';

export function ColorBrand() {
	return (
		<>
			<h3>Main Colors</h3>
			<ul className={`flex align-center gap-s`}>
				<li
					className={`${classes.color_list_item} bg_color_primary_lightest`}
				></li>
				<li
					className={`${classes.color_list_item} bg_color_primary_lighter`}
				></li>
				<li
					className={`${classes.color_list_item} ${classes.color_border} bg_color_primary`}
				></li>
				<li
					className={`${classes.color_list_item} bg_color_primary_darker`}
				></li>
				<li
					className={`${classes.color_list_item} bg_color_primary_darkest`}
				></li>
			</ul>
			<h3>Accent Colors</h3>
			<ul className={`flex align-center gap-s`}>
				<li
					className={`${classes.color_list_item} bg_color_secondary_lightest`}
				></li>
				<li
					className={`${classes.color_list_item} bg_color_secondary_lighter`}
				></li>
				<li
					className={`${classes.color_list_item} ${classes.color_border}  bg_color_secondary`}
				></li>
				<li
					className={`${classes.color_list_item} bg_color_secondary_darker`}
				></li>
				<li
					className={`${classes.color_list_item} bg_color_secondary_darkest`}
				></li>
			</ul>
			<h3>Grey Colors</h3>
			<ul className={`flex align-center gap-s`}>
				<li
					className={`${classes.color_list_item} bg_color_grey_light`}
				></li>
				<li
					className={`${classes.color_list_item} ${classes.color_border} bg_color_grey`}
				></li>
				<li
					className={`${classes.color_list_item} bg_color_grey_dark`}
				></li>
			</ul>
		</>
	);
}
