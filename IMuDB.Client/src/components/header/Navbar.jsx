import React from 'react';
import logo from '../../assets/logo/IMuDBTextLogo.svg';
import { NavLink } from 'react-router';

export default function Navbar() {
	return (
		<nav className="flex space-between">
			<div className="col-center line-height-none">
				<NavLink className="header-logo_link" to="/">
					<img
						className="header-logo_img"
						alt="Logo for Internet Music Database"
						src={logo}
					/>
				</NavLink>
			</div>
			<div className="col-center flex space-between">
				<NavLink className="col-center btn-text btn-nav m-y-s" to="/artists">
					Artists
				</NavLink>

				<NavLink className="col-center btn-text btn-nav m-y-s" to="/albums">
					Albums
				</NavLink>
			</div>
			<div className="col-center flex">
				<NavLink className="col-center btn-text btn-nav" to="/login">
					Login/Sign Up
				</NavLink>
			</div>
		</nav>
	);
}
