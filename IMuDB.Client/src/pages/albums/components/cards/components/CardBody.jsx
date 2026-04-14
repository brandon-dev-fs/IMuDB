import classes from './CardBody.module.css';

export function CardBody({ children }) {
	return <div className={classes.card_body}>{children}</div>;
}
