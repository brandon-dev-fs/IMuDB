import logo from '../../assets/logo/IMuDBRecordLogo.svg';
export default function Footer() {
	const year = new Date().getFullYear();

	return (
		<footer className="footer p-s flex space-between">
			<div className="col-center">
				<p>Website designed and coded by Brandon Thornburg.</p>
				<p>For demo purposes only.</p>
				<p>To reach out to Brandon email at <a href="mailto:Brandonathornburg@gmail.com"><i className="fa-regular fa-envelope"></i>Brandonathornburg@gmail.com</a></p>
			</div>
			<div className="col-center">
				<img
					className="footer-logo_img"
					alt="Logo for Internet Music Database"
					src={logo}
				/>
			</div>
			<div className="col-center">
				<p>&#169; Fake-Copyright {year} IMuDB. Some rights reserved.</p>
				<p>Some images AI generated.</p>
			</div>

		</footer>
	);
}