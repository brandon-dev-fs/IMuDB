import classes from './ModalHeader.module.css';

export default function ModalHeader({ children, onToggleModal }) {
	return (
		<div className={classes.modal_header}>
			<h2>{children}</h2>
			<button
				className="btn-close"
				onClick={onToggleModal}
			>
				<i className="fa-solid fa-x"></i>
			</button>
		</div>
	);
}
