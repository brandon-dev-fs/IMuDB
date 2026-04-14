import React from "react";
import classes from "./Loading.module.css";

function Loading() {
    return (
        <section className={classes.loading}>
            <p className={classes.loading_text}>Loading ...</p>
        </section>
    )
}

export default Loading;