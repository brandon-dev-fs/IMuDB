import { RouteConfig } from "@react-router/dev/routes"

import AlbumDetailsPage from '../components/album/AlbumDetailsPage.jsx';
import AlbumsPage from ;
import ArtistDetailsPage from '../components/artist/ArtistDetailsPage.jsx';
import ArtistsPage from '../components/artist/ArtistsPage.jsx';
import Home from '../components/home/Home.jsx';
import ErrorPage from ;

const ComponentsRoute = "../components/"

export default [
    route("/", "../components/home/Home.jxs"),
    route("/artists", '../components/artist/ArtistsPage.jsx'),
/*    route("/artists/:id",),*/
    route("/albums", '../components/album/AlbumsPage.jsx'),
/*    route("/albums/:id",),*/
    route("/404", '../components/.jsx')
]