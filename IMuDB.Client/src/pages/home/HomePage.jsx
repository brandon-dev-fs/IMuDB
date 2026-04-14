import concert from '../../assets/images/homepage/concert.png';
import records from '../../assets/images/homepage/records.png';
import scrolling from '../../assets/images/homepage/scrolling.png';
import ContentCarousel from './components/contentCarousel/ContentCaroursel';
import HomeHero from './components/hero/HomeHero';
import classes from './HomePage.module.css';

const heroComponents = [
	{
		img: {
			src: records,
			alt: 'Stack of records',
		},
		header: 'The Internets Record Collection',
		body: (
			<>
				<p>A vast collection of artist and records.</p>
				<p>
					Spanning multiple decades and genres, looking through our
					archive is like looking through a audiophiles{' '}
					<strong>record collection</strong>.
				</p>
			</>
		),
	},
	{
		img: {
			src: concert,
			alt: 'Concert',
		},
		header: 'Explore Discover Contribute',
		body: (
			<>
				<p>
					<strong>Explore</strong> music old and new.
				</p>
				<p>
					<strong>Discover</strong> new genres, and develop new taste
				</p>
				<p>
					<strong>Contribute</strong> by adding or updating your
					favorite artist, band, or album.
				</p>
			</>
		),
	},
	{
		img: {
			src: scrolling,
			alt: 'Man in jacket scrolling on phone',
		},
		header: 'Personalize',
		body: (
			<>
				<p>
					<strong>Create</strong> your own playlist, rate artist and
					albums, or track your home record collection.
				</p>
				<p>Share your thoughts and favorites on social media.</p>
			</>
		),
	},
];

export default function HomePage() {
	return (
		<div className={`flex direction-column gap-l`}>
			<HomeHero />
			<ContentCarousel components={heroComponents} />
		</div>
	);
}
