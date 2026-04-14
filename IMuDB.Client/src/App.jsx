import { createBrowserRouter, RouterProvider } from 'react-router-dom';
import AlbumDetails from './components/album/details/AlbumDetails';
import ActsPage from './pages/acts/ActsPage';
import AlbumsPage from './pages/albums/AlbumsPage';
import BrandingPage from './pages/brand/BrandingPage';
import ErrorPage from './pages/error/ErrorPage';
import HomePage from './pages/home/HomePage';
import RootLayout from './pages/RootLayout/RootLayout';

const router = createBrowserRouter([
	{
		path: '/',
		element: <RootLayout />,
		children: [
			{
				element: <HomePage />,
				path: '/',
			},
			{
				element: <ActsPage />,
				path: '/acts',
				children: [],
			},
			{
				element: <AlbumsPage />,
				path: '/albums',
				children: [],
			},
			{
				element: <AlbumDetails />,
				path: '/albums/:id',
			},
			{
				element: <BrandingPage />,
				path: '/design/',
			},
			{
				element: <ErrorPage />,
				path: '*',
			},
		],
	},
]);

function App() {
	return <RouterProvider router={router} />;
}

export default App;
