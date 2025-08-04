import { Route, Routes  } from 'react-router';
import AlbumDetailsPage from './components/album/AlbumDetailsPage';
import AlbumsPage from './components/album/AlbumsPage';
import ArtistDetailsPage from './components/artist/ArtistDetailsPage';
import ArtistsPage from './components/artist/ArtistsPage';
import Footer from './components/footer/Footer';
import Header from './components/header/Header';
import HomePage from './components/home/HomePage';
import ErrorPage from './components/404/ErrorPage';
import './styles/main.css';
function App() {
	return (
		<>
			<Header />
			<main className="app-background p-y-l">
				<Routes>
					<Route path="/" element={<HomePage />} />
					<Route path="/artists" element={<ArtistsPage />}  />
					<Route path="/artists/:id" element={<ArtistDetailsPage />} />
					<Route path="/albums" element={<AlbumsPage />} />
					<Route path="/albums/:id" element={<AlbumDetailsPage />} />
					<Route path="*" element={<ErrorPage />} />
				</Routes>
			</main>
			<Footer />
		</>
	);
}

export default App;