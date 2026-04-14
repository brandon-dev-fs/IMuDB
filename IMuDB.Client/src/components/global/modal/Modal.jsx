import React from 'react';
import classes from './Modal.module.css';

export default function Modal({ children, onToggleModal}) {
    return (
		<div className={classes.modal}>
			<div className={classes.modal_content}>
				{children}
				{/* <div className={classes.modal_header}>
                    {modalTitle ? <h2>{modalTitle}</h2>: <h2>Modal Title</h2>}
                    
                </div>
                <div className={classes.modal_body}>
                    {children}
                </div>
                <div>
                </div> */}
			</div>
		</div>
	);
}

// Modal element should have a title
// Some action in the body such as a form
// Some action footer