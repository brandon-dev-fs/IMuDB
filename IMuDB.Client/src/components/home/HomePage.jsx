import React from 'react';

export default function HomePage() {
	return (
		<article className="page">
			<div className="page-heading">
				<h1>Welcome to the Internet Music DataBase</h1>
			</div>
			<div className="page-content">
				<section className="page-content_section">
					<h2>
						The internets only music database, except all of the other ones.
					</h2>
					<p>
						An internet archive of music's artist and albums with the goal of including all music regardless of genre.
					</p>
				</section>
				<section className="page-content_section">
					<h2 >
						Explore and Contribute
					</h2>
					<p>
						Explore music old and new. Discover new genres, and develop new taste
					</p>
					<p>
						Something Missing? Contribute by adding an artist/band or album.
					</p>
					<p>
						Something Wrong? Submit a correction, and if you can cite any sources.
					</p>
				</section>

				<section className="page-content_section">
					<h2>
						Personalize.
					</h2>
					<p>
						Create playlist or rate artist and albums. Share your favorites on social media and discuss.
					</p>
				</section>
			</div>
		</article>
	);
}
