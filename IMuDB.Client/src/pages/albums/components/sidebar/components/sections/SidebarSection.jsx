import classes from './SidebarSection.module.css';

export function SidebarSection({ children }) {
	return (
		<div className={`${classes.albums_sidebar_container}`}>{children}</div>
	);
}
