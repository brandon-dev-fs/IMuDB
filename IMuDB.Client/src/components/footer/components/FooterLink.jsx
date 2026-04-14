import classes from './FooterLink.module.css';

export function FooterLink({ href, children }) {
	return (
		<a
			target="_blank"
			className={`${classes.footer_link}`}
			href={href}
		>
			{children}
		</a>
	);
}
