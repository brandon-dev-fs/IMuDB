import { CardImage } from './components/CardImage';
import { CarouselCard } from './components/CarouselCard';
import { CarouselNav } from './components/CarouselNav';
import classes from './ContentCaroursel.module.css';
import { useState } from 'react';

export default function ContentCarousel({ components }) {
	const [activeCardIndex, setActiveCardIndex] = useState(0);
	const elements = components.length;

	const handlePrevious = () => {
		setActiveCardIndex((i) => (i > 0 ? i - 1 : elements - 1));
	};

	const handleNext = () => {
		setActiveCardIndex((i) => (i < elements - 1 ? i + 1 : 0));
	};

	return (
		<div className="flex direction-column gap-s">
			{components.map(
				(item, i) =>
					activeCardIndex === i && (
						<CarouselCard key={i}>
							<CardImage
								src={item.img.src}
								alt={item.img.alt}
							/>
							<div className="p-m">
								<h2 className={`${classes.content_header}`}>
									{item.header}
								</h2>
								{item.body}
							</div>
						</CarouselCard>
					),
			)}
			<CarouselNav
				onPrev={handlePrevious}
				onNext={handleNext}
				activeItem={activeCardIndex}
				items={elements}
			/>
		</div>
	);
}
