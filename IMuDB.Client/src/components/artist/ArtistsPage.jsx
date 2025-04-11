import React, { useEffect, useState } from 'react';
import { getArtist } from '../../services/httprequest';
import ArtistList from './ArtistList';
import AddUpdateArtistForm from './AddUpdateArtist';
import Loading from '../loading/loading';
import SearchBar from '../searchbar/SearchBar'
import FilterBar from '../filter/filterbar';

export default function ArtistsPage() {
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState(false);
    const [artists, setArtists] = useState([]);
    const [searchedArtist, setSearchedArtist] = useState([]);
    const [filteredArtist, setFilteredArtist] = useState([]);
    //const [editArtist, setEditArtist] = useState(null);
    const [modalToggle, setModalToggle] = useState(false)

    useEffect(() => {
        getArtist()
            .then(a => {
                console.log(a);
                setLoading(false);
                setArtists(a);
                setFilteredArtist(artists);
                setSearchedArtist(filteredArtist);
            })
            .catch(e => {
                console.log(e);
                setLoading(false);
                setError(true);
            });
    }, [modalToggle]);

    // Artist => filteredArtist => searchedArtist

    if (loading || error) {
        return (
            <div>
                {loading && <Loading />}
                {error && <h2>Error</h2>}
            </div>
        );
    } else {
        return (
            <div className="container">
                {filteredArtist && (
                    <>
                        <div className="container-banner">
                            <h2>Artists</h2>
                            <SearchBar placeholder="Search Artist" list={artists} setSearchedList={setSearchedArtist} />
                            <button type="button" onClick={() => setModalToggle(true)} className="button add-button">
                                Add New Artist
                            </button>
                        </div>
                        <div className="container-body">
                            <div className="filter">
                                <form onChange={e => handleFilter(e)}>
                                    <h3>Filters</h3>
                                    <div className="form-section">
                                        <h4>Type</h4>
                                        <input id="AllRadio" name="typeRadio" type="radio" value={-1} /><label htmlFor="AllRadio">All</label>
                                        <input id="SoloRadio" name="typeRadio" type="radio" value={0} /><label htmlFor="SoloRadio">Solo</label>
                                        <input id="BandRadio" name="typeRadio" type="radio" value={1} /><label htmlFor="BandRadio">Band</label>
                                    </div>
                                    <div className="form-section">
                                        <h4>Number of Members</h4>
                                        <input id="NumberOfMembers" name="NumberOfMembers" type="number" min={1} max={4} /><label htmlFor="NumberOfMembers"></label>
                                    </div>
                                </form>
                            </div>
                            <div>
                                <ArtistList
                                    artists={filteredArtist}
                                />
                            </div>

                        </div>
                    </>
                )}
                <AddUpdateArtistForm modalToggle={modalToggle} setModalToggle={setModalToggle} />
            </div>
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