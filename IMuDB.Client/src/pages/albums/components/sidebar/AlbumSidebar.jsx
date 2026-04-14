import classes from './AlbumSidebar.module.css';
import { SidebarSection } from './components/sections/SidebarSection';

export default function AlbumsSideBar({children}) {
	return (
		<aside className={`${classes.acts_sidebar}`}>
			{children.map((child, i) => (
				<SidebarSection key={i}>
					{child}
				</SidebarSection>
			))}
		</aside>
	);
}
