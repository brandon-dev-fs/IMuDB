import Time from '../Time'

function SongDetails({ song }) {
	return (
		<div className="p-s">
			{/*<iframe src="https://www.youtube.com/embed/0pGOFX1D_jg?si=DfURQQmX4Ge6W9Ml" title={ song.name } width="560" height="315" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture;" referrerpolicy="strict-origin-when-cross-origin"></iframe>*/}
			<div>
				<p style={{ display: "inline" }}>{song.track}</p>. <p style={{ display: "inline" }}>{song.name}</p>
			</div>
			<div>
				<Time milliseconds={song.length} />
			</div>
			<div>
				<p>Lyrics</p>
				<p>
					Love, love me do<br />
					You know I love you,<br />
					I'll always be true,<br />
					So please, love me do<br />
					<br/>
					Whoa, love me do<br />
					<br />
					Love, love me do<br />
					You know I love you,<br />
					I'll always be true,<br />
					So please, love me do<br />
					<br />
					Whoa, love me do<br />
					<br />
					Someone to love,<br />
					Somebody new<br />
					Someone to love,<br />
					Someone like you<br />
				</p>
			</div>
			<div>
				<p>Genre: <span>{song.genre}</span></p>
			</div>

		</div>
	);
}

export default SongDetails;
