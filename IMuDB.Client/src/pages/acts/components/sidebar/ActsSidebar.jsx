import classes from './ActsSidebar.module.css';
import { SidebarSection } from './components/sections/SidebarSection';

export default function ActsSideBar({children}) {
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
