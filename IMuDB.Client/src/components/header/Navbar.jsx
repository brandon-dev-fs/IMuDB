import React from 'react';
import { Link } from 'react-router-dom';
import logo from '../../assets/brand/Plate.svg';
import classes from './Navbar.module.css';

export default function Navbar() {
	return (
		<nav className="flex flex-align-center space-between">
			<div className="flex-grow">
				<img
					className={`image image-smaller`}
					alt="Logo for Internet Music Database"
					src={logo}
				/>
			</div>
			<ul className="flex flex-grow align-center gap-s flex-justify-end">
				<li>
					<Link
						className={`btn ${classes.nav_btn}`}
						to="/"
					>
						Home
					</Link>
				</li>
				<li>
					<Link
						className={`btn ${classes.nav_btn}`}
						to="/design"
					>
						Brand
					</Link>
				</li>
				<li>
					<Link
						className={`btn ${classes.nav_btn}`}
						to="/acts"
					>
						Acts
					</Link>
				</li>
				<li>
					<Link
						className={`btn ${classes.nav_btn}`}
						to="/albums"
					>
						Albums
					</Link>
				</li>
				<li>
					<Link
						className={`btn ${classes.nav_btn}`}
						to="/login"
					>
						Login/Sign Up
					</Link>
				</li>
			</ul>
		</nav>
	);
}
