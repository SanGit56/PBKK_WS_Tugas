<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8" />
        <meta http-equiv="X-UA-Compatible" content="IE=edge" />
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />

        <title><?= NAMA_SITUS . ": " . ucfirst(service('request')->uri->getSegment(1)) . " - " . ucfirst(service('request')->uri->getSegment(2)) ?></title>

        <link href="https://cdn.jsdelivr.net/npm/simple-datatables@7.1.2/dist/style.min.css" rel="stylesheet" />
        <link href="<?= base_url('css/styles.css') ?>" rel="stylesheet" />
        <script src="https://use.fontawesome.com/releases/v6.3.0/js/all.js" crossorigin="anonymous"></script>
    </head>
    <body class="sb-nav-fixed">
        <?php include('_bagian/navbar.php'); ?>

        <div id="layoutSidenav">
            <?php include('_bagian/sidebar.php'); ?>
            
            <div id="layoutSidenav_content">
                <main>
                    <div class="container-fluid px-4">
                        <h1 class="mt-4">Analitik</h1>
                        
                        <ol class="breadcrumb">
                            <?php
                                $segments = service('request')->uri->getSegments();
                                $uriString = service('request')->uri->getPath();

                                foreach ($segments as $segment):
                                    $url = substr($uriString, 0, strpos($uriString, $segment)) . $segment;
                                    $is_active = $url == $uriString;
                                ?>

                                <li class="breadcrumb-item <?php echo $is_active ? 'active' : '' ?>">
                                    <?php if ($is_active): ?>
                                        <?php echo ucfirst($segment) ?>
                                    <?php else: ?>
                                        <a href="<?php echo site_url($url) ?>"><?php echo ucfirst($segment) ?></a>
                                    <?php endif; ?>
                                </li>

                                <?php endforeach;
                            ?>
                        </ol>

                        <div class="row">
                            <div class="col-xl-4 col-md-6">
                                <div class="card text-white bg-warning mb-4">
                                    <div class="card-header d-flex justify-content-between align-items-center">
                                        <h5 class="mb-0">Pengguna</h5>
                                        <i class="fa-solid fa-users fa-3x"></i>
                                    </div>
                                    <div class="card-body text-center">
                                        <h1 class="card-text display-4">147</h1> <!-- Your large font number -->
                                    </div>
                                    <div class="card-footer d-flex align-items-center justify-content-between">
                                        <a class="small text-white stretched-link" href="#">Lihat detail</a>
                                        <div class="small text-white"><i class="fas fa-angle-right"></i></div>
                                    </div>
                                </div>
                            </div>
                            <div class="col-xl-4 col-md-6">
                                <div class="card text-white bg-success mb-4">
                                    <div class="card-header d-flex justify-content-between align-items-center">
                                        <h5 class="mb-0">Penjualan</h5>
                                        <i class="fa-solid fa-bag-shopping fa-3x"></i>
                                    </div>
                                    <div class="card-body text-center">
                                        <h1 class="card-text display-4">97</h1> <!-- Your large font number -->
                                    </div>
                                    <div class="card-footer d-flex align-items-center justify-content-between">
                                        <a class="small text-white stretched-link" href="#">Lihat detail</a>
                                        <div class="small text-white"><i class="fas fa-angle-right"></i></div>
                                    </div>
                                </div>
                            </div>
                            <div class="col-xl-4 col-md-6">
                                <div class="card text-white bg-primary mb-4">
                                    <div class="card-header d-flex justify-content-between align-items-center">
                                        <h5 class="mb-0">Buku</h5>
                                        <i class="fa-solid fa-book fa-3x"></i>
                                    </div>
                                    <div class="card-body text-center">
                                        <h1 class="card-text display-4">48</h1> <!-- Your large font number -->
                                    </div>
                                    <div class="card-footer d-flex align-items-center justify-content-between">
                                        <a class="small text-white stretched-link" href="#">Lihat detail</a>
                                        <div class="small text-white"><i class="fas fa-angle-right"></i></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-xl-6">
                                <div class="card mb-4">
                                    <div class="card-header">
                                        <i class="fas fa-chart-area me-1"></i>
                                        Tren Penjualan
                                    </div>
                                    <div class="card-body"><canvas id="myAreaChart" width="100%" height="40"></canvas></div>
                                </div>
                            </div>
                            <div class="col-xl-6">
                                <div class="card mb-4">
                                    <div class="card-header">
                                        <i class="fas fa-chart-bar me-1"></i>
                                        Penjualan per Bulan
                                    </div>
                                    <div class="card-body"><canvas id="myBarChart" width="100%" height="40"></canvas></div>
                                </div>
                            </div>
                        </div>
                    </div>
                </main>

                <?php include('_bagian/footer.php'); ?>
                
            </div>
        </div>
        <a class="scroll-to-top rounded" href="#page-top">
            <i class="fas fa-angle-up"></i>
        </a>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js" crossorigin="anonymous"></script>
        <script src="<?= base_url('js/scripts.js') ?>"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.8.0/Chart.min.js" crossorigin="anonymous"></script>
        <script src="<?= base_url('assets/demo/chart-area-demo.js') ?>"></script>
        <script src="<?= base_url('assets/demo/chart-bar-demo.js') ?>"></script>
        <script src="https://cdn.jsdelivr.net/npm/simple-datatables@7.1.2/dist/umd/simple-datatables.min.js" crossorigin="anonymous"></script>
        <script src="<?= base_url('js/datatables-simple-demo.js') ?>"></script>
    </body>
</html>