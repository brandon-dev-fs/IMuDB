import { Outlet } from 'react-router-dom';
import Footer from '../../components/footer/Footer';
import Header from '../../components/header/Header';
import classes from './RootLayout.module.css';

function RootLayout() {
    return(<>
        <Header />
        <main className={`${classes.layout}`}>
            <Outlet />
        </main>
        <Footer />
    </>)
}

export default RootLayout;