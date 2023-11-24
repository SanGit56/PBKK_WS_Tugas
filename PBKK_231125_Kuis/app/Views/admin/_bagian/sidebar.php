<div id="layoutSidenav_nav">
    <nav class="sb-sidenav accordion sb-sidenav-dark" id="sidenavAccordion">
        <div class="sb-sidenav-menu">
            <div class="nav">
                <a class="nav-link <?= service('request')->uri->getSegment(2) == 'dashboard' ? 'active': '' ?>" href="index.html">
                    <div class="sb-nav-link-icon"><i class="fas fa-tachometer-alt"></i></div>
                    Analitik
                </a>
                <div class="sb-sidenav-menu-heading">Dashboard</div>
                <a class="nav-link <?= service('request')->uri->getSegment(2) == 'dashboard' ? 'active': '' ?>" href="index.html">
                    <div class="sb-nav-link-icon"><i class="fas fa-columns"></i></div>
                    Produk
                </a>
                <a class="nav-link <?= service('request')->uri->getSegment(2) == 'dashboard' ? 'active': '' ?>" href="index.html">
                    <div class="sb-nav-link-icon"><i class="fas fa-columns"></i></div>
                    Pengguna
                </a>
            </div>
        </div>
        <div class="sb-sidenav-footer">
            <div class="small">Masuk sebagai:</div>
            Administrator
        </div>
    </nav>
</div>