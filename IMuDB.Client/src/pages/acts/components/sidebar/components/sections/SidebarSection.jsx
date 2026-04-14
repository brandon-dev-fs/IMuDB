import classes from './SidebarSection.module.css';

export function SidebarSection({ children }) {
	return (
		<div className={`${classes.acts_sidebar_container}`}>{children}</div>
	);
}
