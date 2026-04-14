function Time({ milliseconds }) {
	const formatTime = (ms) => {
		const s = ms / 1000;

		const min = Math.floor(s / 60);
		const sec = s % 60 < 10 ? '0' + (s % 60) : s % 60;

		return `${min}:${sec}`;
	};

	return (<span>{formatTime(milliseconds)}</span>);
}

export default Time