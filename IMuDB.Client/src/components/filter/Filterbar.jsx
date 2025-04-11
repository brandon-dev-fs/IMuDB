import React from 'react';

export default function FilterBar({ filterForm, list, setFilteredList }) {
    const handleFilter = (e) => {
        const formItems = e.target.value;

        console.log(formItems)

        setFilteredList(list.filter(i => {

        }));
    }

    return (
        <div className="filter">
            <form onChange={e => handleFilter(e)}>
            <h3>Filters</h3>
                {filterForm}
            </form>
        </div>
    );
}