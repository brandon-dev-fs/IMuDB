import classes from './CarouselNav.module.css';

export function CarouselNav({ onPrev, onNext, items, activeItem }) {
	return (
		<div className="flex align-center justify-center gap-s">
			<button
				className="btn-text"
				onClick={onPrev}
			>
				<i className="fa-solid fa-arrow-left"></i>
			</button>
			{Array.from({ length: items }).map((_, i) => (
				<div
					key={i}
					className={`${classes.bubble} ${i === activeItem ? classes.active_bubble : classes.inactive_bubble}`}
				></div>
			))}
			<button
				className="btn-text"
				onClick={onNext}
			>
				<i className="fa-solid fa-arrow-right"></i>
			</button>
		</div>
	);
}
