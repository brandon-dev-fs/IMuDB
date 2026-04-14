import logo from '../../assets/brand/light/RecordLogoWithPlate.svg';
import '../../styles/main.css';
import classes from './Footer.module.css';
import { FooterColumn } from './components/FooterColumn';
import { FooterLink } from './components/FooterLink';

export default function Footer() {
	const year = new Date().getFullYear();

	return (
		<footer className={`flex align-center space-between`}>
			<FooterColumn>
				<p>&#169; Fake-Copyright {year} IMuDB</p>
				<p>
					Cover art sourced from{' '}
					<FooterLink href={'https://covers.musichoarders.xyz/'}>
						musichoarders <i className={`fa-solid fa-arrow-right`} />
					</FooterLink>
				</p>
				<p>Site powered by</p>
				<div>
					<FooterLink
						href={'https://dotnet.microsoft.com/en-us/apps/aspnet'}
					>
						<i
							className={`icons fa-brands fa-microsoft ${classes.footer_icon}`}
						/>
					</FooterLink>
					<FooterLink href={'https://react.dev/'}>
						<i
							className={`icons fa-brands fa-react ${classes.footer_icon}`}
						/>
					</FooterLink>
					<FooterLink href={'https://fontawesome.com/'}>
						<i
							className={`fa-brands fa-font-awesome ${classes.footer_icon}`}
						/>
					</FooterLink>
				</div>
			</FooterColumn>

			<FooterColumn>
				<p>Website is for demo purposes only</p>
				<p>Website was designed and coded by Brandon Thornburg</p>
				<p>Reach out or follow</p>
				<div>
					<FooterLink href={'mailto:Brandonathornburg@gmail.com'}>
						<i
							className={`icons fa-regular fa-envelope ${classes.footer_icon}`}
						/>
					</FooterLink>
					<FooterLink href={'https://github.com/brandon-dev-fs'}>
						<i
							className={`icons fa-brands fa-github ${classes.footer_icon}`}
						/>
					</FooterLink>
					<FooterLink
						href={'https://www.linkedin.com/in/brandon-thornburg/'}
					>
						<i
							className={`icons fa-brands fa-linkedin ${classes.footer_icon}`}
						/>
					</FooterLink>
					<FooterLink
						href={
							'https://bsky.app/profile/brandonthornburg.bsky.social'
						}
					>
						<i
							className={`icons fa-brands fa-bluesky ${classes.footer_icon}`}
						/>
					</FooterLink>
				</div>
			</FooterColumn>
			<FooterColumn>
				<img
					className={`image image-smaller ${classes.footer_logo}`}
					alt="Logo for Internet Music Database"
					src={logo}
				/>
			</FooterColumn>
		</footer>
	);
}