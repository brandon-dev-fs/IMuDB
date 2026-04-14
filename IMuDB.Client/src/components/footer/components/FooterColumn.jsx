import classes from './FooterColumn.module.css';

export function FooterColumn({ children }) {
	return <div className={`${classes.footer_col}`}>{children}</div>;
}
