import React, { useEffect, useState } from 'react';
import Loading from '../../components/loading/Loading';
import { getAct } from '../../services/httprequest';
import classes from './ActsPage.module.css';
import ActDetails from './components/details/ActDetails';
import ActsSideBar from './components/sidebar/ActsSidebar';
import Modal from '../../components/global/modal/Modal';
import ModalHeader from '../../components/global/modal/components/ModalHeader';
import AddUpdateActForm from './components/forms/ActAddUpdateForm';
import ActsSearch from './components/sidebar/components/search/ActsSearch';
import ActsSort from './components/sidebar/components/sort/ActsSort';
import ActFilters from './components/sidebar/components/filters/Filters';
import ActsList from './components/sidebar/components/list/ActsList';

export default function ActsPage() {
	const [loading, setLoading] = useState(true);
	const [acts, setActs] = useState([]);
	const [filteredActs, setFilteredActs] = useState([]);
	const [selectedActId, setSelectedActId] = useState(null);
	const [showModal, setShowModal] = useState(false);

	// Act load should be handled at parent level and pass in the act as an object
	useEffect(() => {
		getAct()
			.then((a) => {
				const sortedActs = a.sort((a, b) =>
					a.name.localeCompare(b.name),
				);
				console.log(a);
				// Set initial props
				setActs(sortedActs);
				setFilteredActs(sortedActs);
				setSelectedActId(sortedActs[0].id);
			})
			.catch((err) => {
				console.error(err);
			})
			.finally(() => setLoading(false));
	}, []);

	const handleSearch = (searchString) => {
		// lazy search for now just direct string compare
		if (searchString) {
			setFilteredActs(
				acts.filter((a) => a.name.toLowerCase().includes(searchString)),
			);
		} else {
			setFilteredActs(acts);
		}
	};

	const handleFilter = (filterType) => {
		if (filterType >= 0) {
			setFilteredActs(acts.filter((a) => a.type === filterType));
		} else {
			setFilteredActs(acts);
		}
	};

	const handleSort = (sortType) => {
		switch (sortType) {
			case 'A-Z':
				setFilteredActs(
					[...acts].sort((a, b) => a.name.localeCompare(b.name)),
				);
				break;
			case 'Z-A':
				setFilteredActs(
					[...acts].sort((a, b) => b.name.localeCompare(a.name)),
				);
				break;
			default:
				setFilteredActs(acts);
				break;
		}
	};

	const handleSetSelectedAct = (id) => {
		setSelectedActId(id);
	};

	const handleShowActModal = () => {
		setShowModal(true);
	};

	const handleHideActModal = () => {
		setShowModal(false);
	};

	const handleAddActSubmit = (act) => {
		console.log(act);
	};

	return loading ? (
		<Loading />
	) : (
		filteredActs && (
			<div className={`${classes.act_page}`}>
				<div className={`flex`}>
					<ActsSideBar>
						<ActsSearch onSearch={handleSearch} />
						<ActsSort
							onSetSort={handleSort}
							sortOptions={['A-Z', 'Z-A']}
						/>
						<ActFilters onSetFilter={handleFilter} />
						<ActsList
							acts={filteredActs}
							onAddAct={handleShowActModal}
							onActSelected={handleSetSelectedAct}
						/>
					</ActsSideBar>
					<ActDetails actId={selectedActId} />
				</div>
				{showModal && (
					<Modal>
						<ModalHeader onToggleModal={handleHideActModal}>
							Add new act
						</ModalHeader>
						<AddUpdateActForm onActSubmit={handleAddActSubmit} />
					</Modal>
				)}
			</div>
		)
	);
}
