import React, { useEffect, useState} from 'react';
import { getArtist } from '../../services/httprequest';
import ArtistList from './ArtistList';
import AddUpdateArtistForm from './AddUpdateArtist';
import Loading from '../loading/loading';
import SearchBar from '../searchbar/SearchBar'
import FilterBar from '../filter/filterbar';

export default function ArtistsPage() {
	const [loading, setLoading] = useState(true);
	//const [artists, setArtists] = useState([]);
	//const [searchedArtist, setSearchedArtist] = useState([]);
	const [filteredArtist, setFilteredArtist] = useState([]);
    //const [editArtist, setEditArtist] = useState(null);
    const [modalToggle/*, setModalToggle*/] = useState(false)

	useEffect(() => {
        getArtist()
            .then(a => {
                console.log(a);
                setLoading(false);
                //setArtists(a);
                setFilteredArtist(a);
                //setSearchedArtist(filteredArtist);
            })
            .catch(e => {
				console.log(e);
				setLoading(false);
		    });

		//setSearchedArtist(filteredArtist);
	}, [modalToggle]);

    // Artist => filteredArtist => searchedArtist

	if (loading) {
		return (
			<article>
				{loading && <Loading />}
			</article>
		);
	} else {
		return (
			<article className="page">
				{filteredArtist && (
					<>
						<div className="page-heading p-s">
							<h1>Artists</h1>
							{/*<SearchBar placeholder="Search Artist" list={artists} setSearchedList={setSearchedArtist} />*/}
							{/*<button type="button" onClick={() => setModalToggle(true)} className="button add-button">*/}
							{/*	Add New Artist*/}
							{/*</button>*/}
						</div>
                        <section className="page-content">
       {/*                     <div className="filter">*/}
							{/*	<form onChange={e => handleFilter(e)}>*/}
							{/*		<h3>Filters</h3>*/}
							{/*		<div className="">*/}
							{/*			<h4>Type</h4>*/}
							{/*			<input id="AllRadio" name="typeRadio" type="radio" value={-1} /><label htmlFor="AllRadio">All</label>*/}
							{/*			<input id="SoloRadio" name="typeRadio" type="radio" value={0} /><label htmlFor="SoloRadio">Solo</label>*/}
							{/*			<input id="BandRadio" name="typeRadio" type="radio" value={1} /><label htmlFor="BandRadio">Band</label>*/}
							{/*		</div>*/}
							{/*		<div className="">*/}
							{/*			<h4>Number of Members</h4>*/}
							{/*			<input id="NumberOfMembers" name="NumberOfMembers" type="number" min={1} max={4} /><label htmlFor="NumberOfMembers"></label>*/}
							{/*		</div>*/}
							{/*	</form>*/}
							{/*</div>*/}
							<ArtistList
								artists={filteredArtist}
							/>

						</section>
					</>
				)}
{/*				<AddUpdateArtistForm modalToggle={modalToggle} setModalToggle={setModalToggle} />*/}
			</article>
		);
	}
}

//<FilterBar filterForm={
//    <>
//        <div className="form-section">
//            <h4>Type</h4>
//            <input id="AllRadio" name="typeRadio" type="radio" value={-1} /><label htmlFor="AllRadio">All</label>
//            <input id="SoloRadio" name="typeRadio" type="radio" value={0} /><label htmlFor="SoloRadio">Solo</label>
//            <input id="BandRadio" name="typeRadio" type="radio" value={1} /><label htmlFor="BandRadio">Band</label>
//        </div>
//        <div className="form-section">
//            <h4>Number of Members</h4>
//            <input id="NumberOfMembers" name="NumberOfMembers" type="number" min={1} max={4} /><label htmlFor="NumberOfMembers"></label>
//        </div>
//    </>
//}
//    list={artists}
//    setFilteredList={setFilteredArtist}
///>