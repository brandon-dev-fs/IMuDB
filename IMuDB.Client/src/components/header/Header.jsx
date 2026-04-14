import classes from './Header.module.css';
import Navbar from './Navbar';
function Header() {
	return (
		<header className={`${classes.header}`}>
			<Navbar />
		</header>
	);
}

export default Header
