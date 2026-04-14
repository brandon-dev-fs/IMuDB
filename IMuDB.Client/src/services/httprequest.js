const ROOT_API = 'https://localhost:4000/api/';

// Gets
//GET
//	/ api / Album X
const getAlbums = async () => {
	return fetch(`${ROOT_API}album`)
		.then((res) => res.json())
		.catch((err) => console.error(err));
};

//GET
//	/ api / Album / { albumId } X
const getAlbumById = async (albumId) => {
	return fetch(`${ROOT_API}album/${albumId}`)
		.then((res) => res.json())
		.catch((err) => console.error(err));
};

//GET
//	/ api / Album / { albumId } / song / { songId }
const getSongById = async (albumId, songId) => {
	return fetch(`${ROOT_API}album/${albumId}/song/${songId}`)
		.then((res) => res.json())
		.catch((err) => console.error(err));
};

//GET
//	/ api / Act X
const getAct = async () => {
	return fetch(`${ROOT_API}act`)
		.then((res) => res.json())
		.catch((err) => console.error(err));
};

//GET
//	/ api / Act / { actId } X
const getActById = async (actId) => {
	return fetch(`${ROOT_API}act/${actId}`)
		.then((res) => res.json())
		.catch((err) => console.error(err));
};

// Puts
//PUT
//	/ api / Album / { albumId } X
const updateAlbum = async (albumId, body) => {
	return fetch(`${ROOT_API}album/${albumId}`, {
		method: 'Put',
		headers: {
			'Content-Type': 'application/json',
		},
		body: JSON.stringify(body),
	})
		.then((res) => res.json())
		.catch((err) => console.error(err));
};
//PUT
//	/ api / Album / { albumId } / song / { songId }
const updateSong = async (albumId, songId, body) => {
	return fetch(`${ROOT_API}album/${albumId}/song/${songId}`, {
		method: 'Put',
		headers: {
			'Content-Type': 'application/json',
		},
		body: JSON.stringify(body),
	})
		.then((res) => res.json())
		.catch((err) => console.error(err));
};
//PUT
//	/ api / Act / { actId }
const updateAct = async (actId, body) => {
	return fetch(`${ROOT_API}act/${actId}`, {
		method: 'Put',
		headers: {
			'Content-Type': 'application/json',
		},
		body: JSON.stringify(body),
	})
		.then((res) => res.json())
		.catch((err) => console.error(err));
};

// Post
//POST
//	/ api / Album
const addAlbum = async (body) => {
	return fetch(`${ROOT_API}album`, {
		method: 'Post',
		headers: {
			'Content-Type': 'application/json',
		},
		body: JSON.stringify(body),
	})
		.then((res) => res.json())
		.catch((err) => console.error(err));
};

//POST
//	/ api / Act
const addAct = async (body) => {
	return fetch(`${ROOT_API}act`, {
		method: 'Post',
		headers: {
			'Content-Type': 'application/json',
		},
		body: JSON.stringify(body),
	})
		.then((res) => res.json())
		.catch((err) => console.error(err));
};

// Deletes
//DELETE
//	/ api / Album / { albumId }
const deleteAlbum = async (albumId) => {
	return fetch(`${ROOT_API}album/${albumId}`, {
		method: 'Delete',
	})
		.then((res) => res.json())
		.catch((err) => console.error(err));
};

//DELETE
//	/ api / Act / { actId }
const deleteAct = async (actId) => {
	return fetch(`${ROOT_API}act/${actId}`, {
		method: 'Delete',
	})
		.then((res) => res.json())
		.catch((err) => console.error(err));
};

// Auth

export {
	addAct,
	addAlbum,
	deleteAct,
	deleteAlbum,
	getAct,
	getActById,
	getAlbumById,
	getAlbums,
	getSongById,
	updateAct,
	updateAlbum,
	updateSong,
};
